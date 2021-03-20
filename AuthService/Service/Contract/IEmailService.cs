using System.Threading.Tasks;
using Domain.Settings;

namespace Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}