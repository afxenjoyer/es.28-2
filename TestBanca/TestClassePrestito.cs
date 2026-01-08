using es._28_2;

namespace TestBanca
{
    [TestClass]
    public class TestClassePrestito
    {
        [TestMethod]
        public void TestToString()
        {
            var esempioCliente = 
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            var esempio =
                new Prestito(esempioCliente, 200.0, 10.5, new DateTime(2024, 5, 12), DateTime.Today);

            Assert.AreEqual
                ($"{esempio.Intestatario}:\n {esempio.Ammontare:0.00} {esempio.Rata:0.00}% {esempio.DataInizio:d} - {esempio.DataFine:d}", esempio.ToString());
        }
    }
}