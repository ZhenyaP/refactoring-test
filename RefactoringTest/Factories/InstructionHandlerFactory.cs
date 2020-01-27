using System.Collections.Generic;
using RefactoringTest.Builders;
using RefactoringTest.Entities;
using RefactoringTest.Enumerations;
using RefactoringTest.Handlers;
using RefactoringTest.Handlers.Interfaces;
using RefactoringTest.Services;

namespace RefactoringTest.Factories
{
    public class InstructionHandlerFactory
    {
        #region Private fields

        private FaxInstructionHandler _faxInstructionHandler;
        private OnlineInstructionHandler _onlineInstructionHandler;
        private WebEntryInstructionHandler _webEntryInstructionHandler;

        #endregion

        #region Properties

        protected FaxInstructionHandler FaxInstructionHandler =>
            _faxInstructionHandler ?? (_faxInstructionHandler = new FaxInstructionHandler(
                new List<IPaymentFileBuilder>
                {
                    new PdfPaymentFaxBuilder(),
                    new PdfReceiptFaxBuilder()
                },
                new PaymentService()));

        protected OnlineInstructionHandler OnlineInstructionHandler =>
            _onlineInstructionHandler ?? (_onlineInstructionHandler = new OnlineInstructionHandler(
                new List<IPaymentFileBuilder>
                {
                    new OnlineInstructionFileBuilder()
                },
                new PaymentService()));

        protected WebEntryInstructionHandler WebEntryInstructionHandler =>
            _webEntryInstructionHandler ?? (_webEntryInstructionHandler = new WebEntryInstructionHandler(
                new List<IPaymentFileBuilder>
                {
                    new PdfPaymentFaxBuilder()
                },
                new PaymentService()
            ));

        #endregion

        public IInstructionHandler GetHandler(Payment payment)
        {
            System.Console.WriteLine("ProcessInstruction on Payment {0}", payment.Id);

            switch (payment.Method)
            {
                case PaymentMethod.Fax:
                    return FaxInstructionHandler;

                case PaymentMethod.Online:
                    return OnlineInstructionHandler;

                default:
                    return WebEntryInstructionHandler;
            }
        }
    }
}