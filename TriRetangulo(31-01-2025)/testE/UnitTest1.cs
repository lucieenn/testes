namespace testE
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //teste #01 triangulo "3,4,3"
            Assert.IsTrue(Triangulo.InstanciaPublica().EhTrianguloRetangulo(3, 4, 5));
            Assert.IsTrue(Triangulo.InstanciaPublica().EhTrianguloRetangulo(5, 4, 3));
            Assert.IsTrue(Triangulo.InstanciaPublica().EhTrianguloRetangulo(3, 5, 4));

            Assert.IsFalse(Triangulo.InstanciaPublica().EhTrianguloRetangulo(4, 4, 4));
            Assert.IsFalse(Triangulo.InstanciaPublica().EhTrianguloRetangulo(0, 0, 0));
        }
    }
}