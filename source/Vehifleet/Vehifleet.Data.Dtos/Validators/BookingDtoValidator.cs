﻿using FluentValidation;

namespace Vehifleet.Data.Dtos.Validators
{
    public class BookingDtoValidator : AbstractValidator<BookingDto>
    {
        public BookingDtoValidator()
        {
            RuleFor(dto => dto.Id)
               .GreaterThanOrEqualTo(0)
               .WithMessage("Invalid Id.");

            RuleFor(dto => dto.VehicleId)
               .GreaterThanOrEqualTo(1)
               .WithMessage("Invalid vehicle Id.");

            RuleFor(dto => dto.EmployeeId)
               .GreaterThanOrEqualTo(1)
               .WithMessage("Invalid employee Id.");

            RuleFor(dto => dto.StartDate)
               .LessThan(dto => dto.EndDate)
               .WithMessage("End date cannot be smaller than start date.");
        }
    }
}