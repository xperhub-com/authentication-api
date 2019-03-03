using FluentValidation.Attributes;
using Nishaan.Solutions.XperhubAPI.ViewModels.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nishaan.Solutions.XperhubAPI.ViewModels
{
    [Validator(typeof(RoleViewModelValidator))]
    public class RoleViewModel
    {
        public string Name { get; set; }
    }
}