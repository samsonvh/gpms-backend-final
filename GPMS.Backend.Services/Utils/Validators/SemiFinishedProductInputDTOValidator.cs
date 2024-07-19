using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using GPMS.Backend.Services.DTOs.Product.InputDTOs;
using GPMS.Backend.Services.DTOs.Product.InputDTOs.Product;

namespace GPMS.Backend.Services.Utils.Validators
{
    public class SemiFinishedProductInputDTOValidator : AbstractValidator<SemiFinishedProductInputDTO>
    {
        public SemiFinishedProductInputDTOValidator()
        {
            RuleFor(inputDTO => inputDTO.Code).NotNull().WithMessage("Code is required");
            RuleFor(inputDTO => inputDTO.Code).MaximumLength(20).WithMessage("Code can not longer than 20 characters");
            RuleFor(inputDTO => inputDTO.Name).NotNull().WithMessage("Name is required");
            RuleFor(inputDTO => inputDTO.Name).MaximumLength(100).WithMessage("Name can not longer than 100 characters");
            RuleFor(inputDTO => inputDTO.Name).Matches(@"^[a-zA-Z0-9 ]*$").WithMessage("Name can not contains special character");
            RuleFor(inputDTO => inputDTO.Description).MaximumLength(500).WithMessage("Description can not longer than 500 characters");
            RuleFor(inputDTO => inputDTO.Quantity).GreaterThan(0).WithMessage("Quantity must greater than 0");
        }
    }
}