namespace TonyJoanes.TemplatePattern
{
    public class CustomerInvoiceTemplatePatternTests
    {
        private CustomerAInvoiceGenerator _customerAInvoiceGenerator;
        private CustomerBInvoiceGenerator _customerBInvoiceGenerator;

        public CustomerInvoiceTemplatePatternTests()
        {
            _customerAInvoiceGenerator = new CustomerAInvoiceGenerator();
            _customerAInvoiceGenerator.GenerateInvoice();
            _customerBInvoiceGenerator = new CustomerBInvoiceGenerator();
            _customerBInvoiceGenerator.GenerateInvoice();
        }

        [Fact]
        public void InvoiceForCustomerA_ShouldHave_CustomerAHeaderText() => Assert.Equal("This is a header for Customer A", _customerAInvoiceGenerator.HeaderText);

        [Fact]
        public void InvoiceForCustomerA_ShouldHave_CustomerAFooterText() => Assert.Equal("This is a footer for Customer A", _customerAInvoiceGenerator.FooterText);

        [Fact]
        public void InvoiceForCustomerB_ShouldHave_CustomerAHeaderText() => Assert.Equal("This is a header for Customer B", _customerBInvoiceGenerator.HeaderText);

        [Fact]
        public void InvoiceForCustomerA_ShouldHave_CustomerBFooterText() => Assert.Equal("This is a footer for Customer B", _customerBInvoiceGenerator.FooterText);
    }

    public abstract class InvoiceGenerator
    {
        public string FooterText { get; set; }
        public string HeaderText { get; set; }

        // Template method defining the invoice generation algorithm
        public void GenerateInvoice()
        {
            // Common steps for generating an invoice
            AddInvoiceHeader();
            AddInvoiceItems();
            CalculateTotalAmount();
            AddInvoiceFooter();
        }

        // Abstract methods to be overridden by derived classes
        protected abstract void AddInvoiceHeader();
        protected abstract void AddInvoiceItems();
        protected abstract void CalculateTotalAmount();
        protected abstract void AddInvoiceFooter();
    }

    public class CustomerAInvoiceGenerator : InvoiceGenerator
    {
        protected override void AddInvoiceHeader()
        {
            // Add Customer A specific invoice header logic
            this.HeaderText = "This is a header for Customer A";
        }

        protected override void AddInvoiceItems()
        {
            // Add Customer A specific invoice item logic
        }

        protected override void CalculateTotalAmount()
        {
            // Add Customer A specific calculation logic
        }

        protected override void AddInvoiceFooter()
        {
            // Add Customer A specific invoice footer logic
            this.FooterText = "This is a footer for Customer A";
        }
    }

    public class CustomerBInvoiceGenerator : InvoiceGenerator
    {
        protected override void AddInvoiceHeader()
        {
            // Add Customer B specific invoice header logic
            this.HeaderText = "This is a header for Customer B";
        }

        protected override void AddInvoiceItems()
        {
            // Add Customer B specific invoice item logic
        }

        protected override void CalculateTotalAmount()
        {
            // Add Customer B specific calculation logic
        }

        protected override void AddInvoiceFooter()
        {
            // Add Customer B specific invoice footer logic
            this.FooterText = "This is a footer for Customer B";
        }
    }
}