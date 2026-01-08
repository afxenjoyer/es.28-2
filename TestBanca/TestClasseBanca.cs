using es._28_2;

namespace TestBanca
{
    [TestClass]
    public class TestClasseBanca
    {
        public Banca BancaTest { get; set; }

        [TestMethod]
        public void TestAggiungiCliente()
        {
            // La funzione AggiungiCliente() deve funzionare (non lanciare un exception)
            BancaTest = new Banca("Banca Bella");
            BancaTest.Clienti = new List<Cliente>();

            var esempioCliente =
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            BancaTest.AggiungiCliente(esempioCliente);

            Assert.AreEqual(esempioCliente, BancaTest.Clienti[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Il cliente è gia nella lista")]
        public void TestAggiungiClienteException()
        {
            // La funzione AggiungiCliente() deve lanciare un exception se il cliente da inserire è gia nella lista
            BancaTest = new Banca("Banca Bella");
            BancaTest.Clienti = new List<Cliente>();

            var esempioCliente =
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            BancaTest.Clienti.Add(esempioCliente);
            BancaTest.AggiungiCliente(esempioCliente);
        }

        [TestMethod]
        public void TestModificaCliente()
        {
            // La funzione ModificaCliente() deve funzionare (non lanciare un exception)
            BancaTest = new Banca("Banca Bella");
            BancaTest.Clienti = new List<Cliente>();

            var esempioCliente =
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            var nuovoCliente =
                new Cliente("Giovanni", "Di Mingo", "nonMettoIlMioCodiceFiscale", 1500.0);

            BancaTest.AggiungiCliente(esempioCliente);
            BancaTest.ModificaCliente(esempioCliente, nuovoCliente);

            Assert.AreEqual(nuovoCliente, BancaTest.Clienti[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Il cliente da modificare non è nella lista")]
        public void TestModificaClienteException()
        {
            // La funzione ModificaCliente() deve lanciare un exception se il cliente da modificare non esiste
            BancaTest = new Banca("Banca Bella");
            BancaTest.Clienti = new List<Cliente>();

            var esempioCliente =
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            var clienteDiverso =
                new Cliente("Aurora", "Di Mingo", "nonMettoIlMioCodiceFiscale", 1000.0);

            var nuovoCliente =
                new Cliente("Giovanni", "Di Mingo", "nonMettoIlMioCodiceFiscale", 1500.0);

            BancaTest.AggiungiCliente(esempioCliente);
            BancaTest.ModificaCliente(clienteDiverso, nuovoCliente);
        }

        [TestMethod]
        public void TestEliminaCliente()
        {
            // La funzione EliminaCliente() deve funzionare (non lanciare un exception)
            BancaTest = new Banca("Banca Bella");
            BancaTest.Clienti = new List<Cliente>();

            var esempioCliente =
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            var esempioCliente2 =
                new Cliente("Aurora", "Di Mingo", "nonMettoIlMioCodiceFiscale", 1000.0);

            BancaTest.AggiungiCliente(esempioCliente);
            BancaTest.AggiungiCliente(esempioCliente2);

            BancaTest.EliminaCliente(esempioCliente);

            Assert.AreEqual(esempioCliente2, BancaTest.Clienti[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Il cliente da eliminare non è nella lista")]
        public void TestEliminaClienteException()
        {
            // La funzione EliminaCliente() deve lanciare un exception se il cliente da eliminare non esiste
            BancaTest = new Banca("Banca Bella");
            BancaTest.Clienti = new List<Cliente>();

            var esempioCliente =
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            var esempioCliente2 =
                new Cliente("Aurora", "Di Mingo", "nonMettoIlMioCodiceFiscale", 1000.0);

            BancaTest.AggiungiCliente(esempioCliente);
            BancaTest.EliminaCliente(esempioCliente2);
        }

        [TestMethod]
        public void TestCercaCliente()
        {
            // La funzione CercaCliente() deve funzionare (non ritornare false)
            BancaTest = new Banca("Banca Bella");
            BancaTest.Clienti = new List<Cliente>();

            var esempioCliente =
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            BancaTest.AggiungiCliente(esempioCliente);

            Assert.IsTrue(BancaTest.CercaCliente(esempioCliente));
        }

        [TestMethod]
        public void TestCercaClienteException()
        {
            // La funzione CercaCliente() deve ritornate false (dato che il cliente non è nella lista)
            BancaTest = new Banca("Banca Bella");
            BancaTest.Clienti = new List<Cliente>();

            var esempioCliente =
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            Assert.IsFalse(BancaTest.CercaCliente(esempioCliente));
        }

        [TestMethod]
        public void TestAggiungiPrestito()
        {
            // La funzione AggiungiPrestito() deve funzionare (non lanciare un exception)
            BancaTest = new Banca("Banca Bella");
            BancaTest.Prestiti = new List<Prestito>();

            var esempioCliente =
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            var esempioPrestito = 
                new Prestito(esempioCliente, 200.0, 10.5, new DateTime(2024, 5, 12), DateTime.Today);

            BancaTest.AggiungiPrestito(esempioPrestito);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Il prestito è gia nella lista")]
        public void TestAggiungiPrestitoException()
        {
            // La funzione AggiungiPrestito() deve lanciare un exception se il prestito da inserire è gia nella lista
            BancaTest = new Banca("Banca Bella");
            BancaTest.Prestiti = new List<Prestito>();

            var esempioCliente =
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            var esempioPrestito =
                new Prestito(esempioCliente, 200.0, 10.5, new DateTime(2024, 5, 12), DateTime.Today);

            BancaTest.Prestiti.Add(esempioPrestito);
            BancaTest.AggiungiPrestito(esempioPrestito);
        }

        [TestMethod]
        public void TestCercaPrestito()
        {
            // La funzione CercaPrestito() deve ritornare una lista di prestiti che contiene solo esempioPrestito
            BancaTest = new Banca("Banca Bella");
            BancaTest.Prestiti = new List<Prestito>();

            var esempioCliente =
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            var esempioPrestito =
                new Prestito(esempioCliente, 200.0, 10.5, new DateTime(2024, 5, 12), DateTime.Today);

            BancaTest.AggiungiPrestito(esempioPrestito);

            List<Prestito> prestitiDelCliente = BancaTest.CercaPrestito(esempioCliente.CodiceFiscale);
            Assert.AreEqual(esempioPrestito, prestitiDelCliente[0]);
        }

        [TestMethod]
        public void TestCercaPrestitoException()
        {
            // La funzione CercaPrestito() deve ritornare una lista vuota
            BancaTest = new Banca("Banca Bella");
            BancaTest.Prestiti = new List<Prestito>();

            var esempioCliente =
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            var esempioCliente2 =
                new Cliente("Giovanni", "Di Mingo", "nonMettoIlMioCodiceFiscaleUnico", 2000.0);

            var esempioPrestito =
                new Prestito(esempioCliente, 200.0, 10.5, new DateTime(2024, 5, 12), DateTime.Today);

            BancaTest.AggiungiPrestito(esempioPrestito);

            List<Prestito> prestitiDelCliente = BancaTest.CercaPrestito(esempioCliente2.CodiceFiscale);
            Assert.IsTrue(prestitiDelCliente.Count == 0);
        }

        [TestMethod]
        public void TestAmmontareTotaleCliente()
        {
            // La funzione AmmontareTotaleCliente() deve funzionare (non ritornare il numero sbagliato)
            BancaTest = new Banca("Banca Bella");
            BancaTest.Prestiti = new List<Prestito>();

            var esempioCliente =
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            var esempioPrestito =
                new Prestito(esempioCliente, 200.0, 10.5, new DateTime(2024, 5, 12), DateTime.Today);

            var esempioPrestito2 =
                new Prestito(esempioCliente, 150.0, 10.5, new DateTime(2024, 5, 12), DateTime.Today);

            BancaTest.AggiungiPrestito(esempioPrestito);
            BancaTest.AggiungiPrestito(esempioPrestito2);

            Assert.AreEqual(esempioPrestito.Ammontare + esempioPrestito2.Ammontare, BancaTest.AmmontareTotaleCliente(esempioCliente.CodiceFiscale));
        }

        [TestMethod]
        public void TestAmmontareTotaleClienteException()
        {
            // La funzione AmmontareTotaleCliente() deve ritornare esattamente 0
            BancaTest = new Banca("Banca Bella");
            BancaTest.Prestiti = new List<Prestito>();

            var esempioCliente =
                new Cliente("Andrea", "Di Mingo", "nonMettoIlMioCodiceFiscale", 2000.0);

            var esempioCliente2 =
                new Cliente("Giovanni", "Di Mingo", "nonMettoIlMioCodiceFiscaleUnico", 2000.0);

            var esempioPrestito =
                new Prestito(esempioCliente, 200.0, 10.5, new DateTime(2024, 5, 12), DateTime.Today);

            var esempioPrestito2 =
                new Prestito(esempioCliente, 150.0, 10.5, new DateTime(2024, 5, 12), DateTime.Today);

            BancaTest.AggiungiPrestito(esempioPrestito);
            BancaTest.AggiungiPrestito(esempioPrestito2);

            Assert.AreEqual(0, BancaTest.AmmontareTotaleCliente(esempioCliente2.CodiceFiscale));
        }
    }
}