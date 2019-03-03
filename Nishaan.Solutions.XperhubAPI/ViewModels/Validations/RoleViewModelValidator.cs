using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nishaan.Solutions.XperhubAPI.ViewModels.Validations
{
    public class RoleViewModelValidator : AbstractValidator<RoleViewModel>
    {
        public RoleViewModelValidator()
        {
            RuleFor(vm => vm.Name).NotEmpty().WithMessage("Role name cannot be empty");
        }
    }
}