using AeroportShatohin.Classes;
using FluentAssertions;
using Microsoft.VisualBasic;

namespace MyLibs
{
    public class TestNuget
    {
        public MyLibsUru.Libd<Flight> resolution = new MyLibsUru.Libd<Flight>();

        public void GetInformation(ref Flight gets)
        {
            gets.numfl = 1;
            gets.TypeAir = airplanes.Airbus;
            gets.TimeIn = DateTime.Parse("05.06.2007");
        }
        public void ChangInf(ref Flight gets)
        {
            gets.numfl = 5;
            gets.TypeAir = airplanes.Boing;
            gets.TimeIn = DateTime.Parse("15.09.2077");
        }


        #region AddBut
        [Fact]
        public void TestAddButton()
        {
        var gets = new Flight();
        GetInformation(ref gets);
        var result = resolution.Add(gets);
        var checkstd = resolution.GetList();
        result.Should().Be(gets);
        checkstd.Should().HaveCount(1).And.NotBeEmpty();
        }
        #endregion

        #region ChangeBut
        [Fact]
        public void TestChangeButton()
        {
            var ooo = new Flight();
            GetInformation(ref ooo);
            var bibop = new Flight();
            ChangInf(ref bibop);
            resolution.Add(ooo);
            resolution.Change(ooo, bibop);
            var check = resolution.GetList();
            check.Should().HaveCount(1).And.NotBeEmpty();
            Assert.Equal(check[0], bibop);
        }
        #endregion

        #region DeleteBut
        [Fact]
        public void Delete()
        {
            var gets = new Flight();
            GetInformation(ref gets);
            resolution.Add(gets);
            resolution.Remove(gets);
            var check = resolution.GetList();
            check.Should().BeEmpty();
        }
        #endregion

    }
}