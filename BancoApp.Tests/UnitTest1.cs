using NUnit.Framework;
using BancoApp;

namespace BancoApp.Tests
{
    [TestFixture]
    public class CuentaTests
    {
        [Test]
        public void Transferir_ConSaldoSuficiente_DebeSerExitosa()
        {
            // Cuenta
            var cuenta = new Cuenta(5000);

            // Transferencia
            var resultado = cuenta.Transferir(2000);

            // Assert
            Assert.That(resultado, Is.True);
            Assert.That(cuenta.Saldo, Is.EqualTo(3000));
        }

        [Test]
        public void Transferir_ConSaldoInsuficiente_DebeFallar()
        {
            var cuenta = new Cuenta(1000);

            var resultado = cuenta.Transferir(2000);

            Assert.That(resultado, Is.False);
            Assert.That(cuenta.Saldo, Is.EqualTo(1000));
        }

        [Test]
        public void Transferir_MontoNegativo_DebeFallar()
        {
            var cuenta = new Cuenta(3000);

            var resultado = cuenta.Transferir(-500);

            Assert.That(resultado, Is.False);
            Assert.That(cuenta.Saldo, Is.EqualTo(3000));
        }
    }
}
