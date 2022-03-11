﻿using FourWheels.Repository.Entities;

namespace FourWheels.Service.Interfaces
{
    public interface IArbejdsOrdrerService : IGenericService<Arbejdsordrer>
    {
        Task<List<Arbejdsordrer>> GetAllAOIncludeMek();
    
    }
    
}