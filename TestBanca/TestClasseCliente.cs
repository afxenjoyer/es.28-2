using es._28_2;

namespace TestBanca
{
    [TestClass]
    public class TestClasseCliente
    {
        [TestMethod]
        public void TestToString()
        {
            var esempio = new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            Assert.AreEqual($"{esempio.Nome} {esempio.Cognome} {esempio.CodiceFiscale}:{esempio.Stipendio:0.00}", esempio.ToString());
        }
    }
}