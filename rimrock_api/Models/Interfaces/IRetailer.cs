﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rimrock_api.Models.Interfaces
{
	public interface IRetailer
	{
		Task<List<Retailer>> Get();

		Task<Retailer> Get(int id);
	}
}
