using BL.BLApi;
using BL.BLModels;
using Common;
using DAL;
using DAL.DALImplementation;
using DAL.DALModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLImplementation;

public class BLPaymentService : IBLPaymentService
{
    DALPaymentService paymentService;
    public BLPaymentService(DALManager paymentService)
    {
        this.paymentService = paymentService.Payments;
    }
    public Task<Payment> Create(BLPayment entity)
    {
        throw new NotImplementedException();
    }

    public Task<Payment> Delete(string id)
    {
        throw new NotImplementedException();
    }

    public List<BLPayment> GetAll(BaseQueryParams queryParams)
    {
        Task<PagedList<Payment>> pagedPayments = paymentService.GetAllAsync(queryParams);
        List<BLPayment> paymentList = new List<BLPayment>();
        foreach (var payment in pagedPayments.Result)
        {
            BLPayment newPayment = new BLPayment();
            newPayment.PaymentId = payment.PaymentId;
            newPayment.OwnerId = payment.OwnerId;
            newPayment.CreditCardNumber = payment.CreditCardNumber;
            newPayment.Validity = payment.Validity;
            newPayment.Cvv = payment.Cvv;
            paymentList.Add(newPayment);
        }
        return paymentList;
    }

    public Task<Payment> Update(string id, BLPayment entity)
    {
        throw new NotImplementedException();
    }
}
