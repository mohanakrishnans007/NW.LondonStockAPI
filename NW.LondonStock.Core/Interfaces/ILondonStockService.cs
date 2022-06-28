﻿using NW.LondonStock.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.LondonStock.Core.Interfaces
{
    public interface ILondonStockService
    {
        Task <CoreLondonStockResponse> GetStockDetails(DTO.CoreLondonStockRequest stockApiRequest);
    }
}
