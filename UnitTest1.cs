using System;
using Xunit;

namespace RownanieKwadratowe1.Testy
{
    public class RownanieKwadratoweTesty
    {
        [Fact]
        public void liczRownanie_Sprawdzanie_obliczeñ()
        {
            //arrange
            RownanieKwadratowe o1 = new RownanieKwadratowe();
            o1.a = -2;
            o1.b = 1;
            o1.c = 3;
            double wynik = 25;

            //act

            o1.liczRownanie();
            double wynikDelty=o1.delta;



            //assert

            Assert.Equal(wynikDelty, wynik);


            

        }
    }
}