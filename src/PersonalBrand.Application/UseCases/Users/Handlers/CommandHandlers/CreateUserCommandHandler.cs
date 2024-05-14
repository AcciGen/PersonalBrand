using MediatR;
using Microsoft.AspNetCore.Identity;
using PersonalBrand.Application.UseCases.Users.Commands;
using PersonalBrand.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBrand.Application.UseCases.Users.Handlers.CommandHandlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, ResponseModel>
    {
        private readonly UserManager<UserModel> _manager;

        public CreateUserCommandHandler(UserManager<UserModel> manager)
        {
            _manager = manager;
        }

        public async Task<ResponseModel> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new UserModel
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
            };

            await _manager.CreateAsync(user, request.Password);
            return new ResponseModel
            {
                Message = "Yaratildi",
                IsSuccess = true,
                StatusCode = 201
            };
        }
    }
}
