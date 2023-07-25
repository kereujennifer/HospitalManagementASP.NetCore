using System.Threading.Tasks;

namespace ABNO_Softwares_Products
{
    internal interface IEmailSender
    {
        Task SendEmailAsync(string email, string v1, string v2);
    }
}