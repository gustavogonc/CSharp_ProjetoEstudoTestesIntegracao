﻿using ProjetoEstudoTestes.Domain.Requests.User;

namespace ProjetoEstudoTestes.Business.UserBusiness
{
    public interface IUserBusiness
    {
        Task<IResult> ListUsersAsync();
        Task<IResult> CreateUserAsync(UserCreateRequest userRequest);
        Task<IResult> ListBooksCreatedByUserAsync(Guid id);
        Task<IResult> UpdateUserAsync(Guid id, UserUpdateRequest user);
        Task<IResult> DeleteUserAsync(Guid id, Guid idBody);
    }
}
