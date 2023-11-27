using APIKel27.Models.Dto;

namespace APIKel27.Data
{
    public static class AccountStore
    {
        public static List<AccountDTO> accountList = new List<AccountDTO>
        {
             new AccountDTO{Id=1, Username="salahudin", Password="inibukanpassword"},
             new AccountDTO{Id=2, Username="ilham", Password="bukanpassword"}
        };
    }
}
