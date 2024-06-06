﻿using RedCloud.Application.Features.Numbers.Commands;
using RedCloud.ViewModel;

namespace RedCloud.Interfaces
{
    public interface INumberService<T>
    {

        Task<int> AddNumber(NumberVM numberVM);
        Task<AssignNumberViewModel> GetNumberById(int eventId);

        Task UpdateNumber(AssignNumberViewModel assignNumberViewModel);
    }
}
