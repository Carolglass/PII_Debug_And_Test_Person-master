//La tarea consiste en agregar casos de prueba para verificar que no se pueda asignar cédulas o nombres inválidos; 
//y que se puedan asignar cuando sean válidos.

using UnitTestAndDebug;
using NUnit.Framework;


namespace UnitTestAndDebug
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        //Test para darse cuenta que la informacion para la persona esta vacia y no es correcto
        [Test]
        public void Invalid1() 
        {
            string expectedname = null;
            string expectedID = null;
            Person prueba = new Person("","");
            Assert.AreEqual(expectedname,prueba.Name);
            Assert.AreEqual(expectedID , prueba.ID);
        }

        //Test para darse cuenta que el nombre es válido pero la ID no
        [Test]
        public void Invalid2() 
        {
            string expectedname = "Carol Glass";
            string expectedID = null;
            Person prueba = new Person("Carol Glass","1234567-8");
            Assert.AreEqual(expectedname,prueba.Name);
            Assert.AreEqual(expectedID , prueba.ID);
        }

        //Test para darse cuenta que el nombre es válido pero la ID no
        [Test]
        public void Invalid3() 
        {
            string expectedname = "Carol Glass";
            string expectedID = null;
            Person prueba = new Person("Carol Glass","00000");
            Assert.AreEqual(expectedname,prueba.Name);
            Assert.AreEqual(expectedID , prueba.ID);
        }

        //Test para darse cuenta que el nombre es válido y la ID tambien
        [Test]
        public void Valid1() 
        {
            string expectedname = "Carol Glass";
            string expectedID = "4912256-8";
            Person prueba = new Person("Carol Glass","4912256-8");
            Assert.AreEqual(expectedname,prueba.Name);
            Assert.AreEqual(expectedID , prueba.ID);
        }

        //Test para darse cuenta que el nombre es válido y la ID tambien poniendo el ID con los puntos
        [Test]
        public void Valid2() 
        {
            string expectedname = "Vivian";
            string expectedID = "2.613.472-0";
            Person prueba = new Person("Vivian","2.613.472-0");
            Assert.AreEqual(expectedname,prueba.Name);
            Assert.AreEqual(expectedID , prueba.ID);
        }



    }
}