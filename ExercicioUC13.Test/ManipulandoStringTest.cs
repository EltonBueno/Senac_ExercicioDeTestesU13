using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ExercicioUC13.Core;

namespace ExercicioUC13.Test
{
    public class ManipulandoStringTest
    {
       
        [Theory]
        [InlineData("Pedro")]
        [InlineData("Pedro Henrique")]
        public void OlaPessoa_recebeNome_devolveBoasVindas(string nome)
        {
            //Arrange

            //Act
            var resultado = ManipulandoStrings.OlaPessoa(nome);
            //Assert
            Assert.Equal($"Olá {nome}", resultado);
        }
        
        [Theory]
        [InlineData ("")]
        [InlineData ("Pedro ")]
        [InlineData ("Pedro!")]
        [InlineData ("!!")]
        [InlineData ("12234")]
        public void OlaPessoa_recebeNome_devolveVazio(string nome)
        {
            //Arrange

            //Act
            var resultado = ManipulandoStrings.OlaPessoa(nome);
            //Assert
            Assert.Equal("", resultado);
        }
        
        

        [Fact]
        public void ExtrairMensagemDoLog_ExibirMensagemInfo()
        {

            //Arrange

            //Act
            var  resultado = ManipulandoStrings.ExtrairMensagemDoLog("[INFO]: Operação concluída");
            //Assert
            Assert.Equal("Operação concluída", resultado); 

        } 
        
        [Fact]
        public void ExtrairMensagemDoLog_ExibirMensagemError()
        {

            //Arrange

            //Act
            var  resultado = ManipulandoStrings.ExtrairMensagemDoLog("[ERROR]: Operação inválida");
            //Assert
            Assert.Equal("Operação inválida", resultado); 

        } 
        
        [Fact]
        public void ExtrairMensagemDoLog_ExibirMensagemWarning()
        {

            //Arrange

            //Act
            var  resultado = ManipulandoStrings.ExtrairMensagemDoLog("[WARNING]: Conexão limitada");
            //Assert
            Assert.Equal("Conexão limitada", resultado); 

        }

        [Fact]
        public void RemoveEspacosDuplicados_RemoveEspacoDuplo()
        {

            //Arrange

            //Act
            var resultado = ManipulandoStrings.RemoveEspacosDuplicados("Bom  dia");

            //Assert
            Assert.Equal("Bom dia", resultado);


        }

        [Fact]
        public void RemoveEspacosDuplicados_RemoveEspacoExtrasnoInicioEFIm()
        {

            //Arrange

            //Act
            var resultado = ManipulandoStrings.RemoveEspacosDuplicados("  Bom dia  ");

            //Assert
            Assert.Equal(" Bom dia ", resultado);


        }
        
        [Fact]
        public void RemoveEspacosDuplicados_RemoveEspaconoInicioEFIm()
        {

            //Arrange

            //Act
            var resultado = ManipulandoStrings.RemoveEspacosDuplicados(" Bom dia ");

            //Assert
            Assert.Equal("Bom dia", resultado);


        }
        
        [Fact]
        public void RemoveEspacosDuplicados_RemoveVariosEspacos()
        {

            //Arrange

            //Act
            var resultado = ManipulandoStrings.RemoveEspacosDuplicados(" Bom              dia ");

            //Assert
            Assert.Equal("Bom dia", resultado);


        }

    }
}
