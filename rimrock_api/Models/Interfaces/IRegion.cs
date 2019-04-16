﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rimrock_api.Models.Interfaces
{

	public interface IRegion
	{
        Task<List<Region>> Get();

        Task<Region> Get(int id);
    }
}