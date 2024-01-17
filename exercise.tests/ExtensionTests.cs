using exercise.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void Tests()
        {

            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            User user = new User("Emailisechtnietvalide", "wachtwoord123");

            string output = stringWriter.ToString();
            Assert.That(output, Is.EqualTo("Invalid email\r\n"));
        }

        [Test]
        public void Tests2()
        {

            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            User user = new User("Valid@email", "short");

            string output = stringWriter.ToString();
            Assert.That(output, Is.EqualTo("Invalid password\r\n"));
        }
        [Test]
        public void Tests3()
        {

            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            User user = new User("Valid@email", "validShort");

            string output = stringWriter.ToString();
            Assert.IsEmpty(output);
        }
    }
}
