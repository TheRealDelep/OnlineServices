﻿using SandwichSystem.BusinessLayer.Extentions;
using SandwichSystem.Shared.TransfertObjects;
using System;

namespace SandwichSystem.BusinessLayer.UseCases.Assistante
{
    public partial class Assistante
    {
        public bool RemoveSupplier(SupplierTO Supplier)
        {
            try
            {
                if (Supplier is null)
                    throw new ArgumentNullException(nameof(Supplier));

                if (Supplier.Id == 0)
                    throw new Exception("Supplier not in DB.");

                iUnitOfWork.SupplierRepository.Delete(Supplier.ToDomain().ToTransfertObject());

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
