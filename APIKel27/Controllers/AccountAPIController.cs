using Microsoft.AspNetCore.Mvc;
using APIKel27.Models.Dto;
using APIKel27.Data;

namespace APIKel27.Controllers
{
    [Route("api/AccountAPI")]
    [ApiController]
    public class AccountAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<AccountDTO>> GetAccounts()
        {
            return Ok(AccountStore.accountList);
        }

        [HttpGet("{Id:int}", Name = "GetAccount")]
        [ProducesResponseType(200, Type = typeof(AccountDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(404)]

        public ActionResult<AccountDTO> GetAccount(int id)
        {
            if (id == 0) return BadRequest();
            var acc = AccountStore.accountList.FirstOrDefault(u => u.Id == id);
            if (acc == null) return NotFound();
            return Ok(acc);
        }

        [HttpPost]
        public ActionResult<AccountDTO> CreateAcc([FromBody] AccountDTO accountDTO)
        {
            if (AccountStore.accountList.FirstOrDefault(u => u.Username.ToLower() == accountDTO.Username.ToLower()) != null)
            {
                ModelState.AddModelError("CustomError", "Account already exists");
                return BadRequest(ModelState);
            }

            if (accountDTO == null)
            {
                return BadRequest(accountDTO);
            }

            if (accountDTO.Id != 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            accountDTO.Id = AccountStore.accountList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            AccountStore.accountList.Add(accountDTO);
            string response = "Sukses menambahkan data Akun" + "\nNama : " + accountDTO.Username;
            return CreatedAtRoute("GetAccount", new { id = accountDTO.Id }, response);
        }

        [HttpDelete("{id:int}", Name = "DeleteAccount")]
        public IActionResult DeleteAccount(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var acc = AccountStore.accountList.FirstOrDefault(u => u.Id == id);
            if (acc == null)
            {
                return NotFound();
            }
            AccountStore.accountList.Remove(acc);
            return NoContent();
        }

        [HttpPut("{id:int}", Name = "UpdateAccount")]
        public IActionResult UpdateAccount(int id, [FromBody] AccountDTO accountDTO)
        {
            if (accountDTO == null || id != accountDTO.Id)
            {
                return BadRequest();
            }
            var akun = AccountStore.accountList.FirstOrDefault(u => u.Id == id);
            akun.Username = accountDTO.Username;
            akun.Password = accountDTO.Password;
            return NoContent();
        }
    }
};
