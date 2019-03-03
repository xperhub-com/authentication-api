
using Nishaan.Solutions.XperhubAPI.ViewModels.Validations;
using FluentValidation.Attributes;

namespace Nishaan.Solutions.XperhubAPI.ViewModels
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}