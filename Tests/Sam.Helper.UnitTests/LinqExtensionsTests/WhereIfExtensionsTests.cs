using System.Linq;
using Sam.Helper.LinqExtensions;

namespace Sam.Helper.UnitTests.LinqExtensionsTests
{
    public class WhereIfExtensionsTests
    {
        #region IQueryable Tests

        [Fact]
        public void WhereIf_Should_Filter_IQueryable_When_Condition_True()
        {
            IQueryable<int> query = new List<int> { 1, 2, 3, 4, 5 }.AsQueryable();
            var filteredQuery = query.WhereIf(true, x => x > 3);
            Assert.Equal(2, filteredQuery.Count());
        }

        [Fact]
        public void WhereIf_Should_Not_Filter_IQueryable_When_Condition_False()
        {
            IQueryable<int> query = new List<int> { 1, 2, 3, 4, 5 }.AsQueryable();
            var filteredQuery = query.WhereIf(false, x => x > 3);
            Assert.Equal(5, filteredQuery.Count());
        }

        #endregion

        #region ICollection Tests

        [Fact]
        public void WhereIf_Should_Filter_ICollection_When_Condition_True()
        {
            ICollection<int> collection = new List<int> { 1, 2, 3, 4, 5 };
            var filteredCollection = collection.WhereIf(true, x => x > 3);
            Assert.Equal(2, filteredCollection.Count);
        }

        [Fact]
        public void WhereIf_Should_Not_Filter_ICollection_When_Condition_False()
        {
            ICollection<int> collection = new List<int> { 1, 2, 3, 4, 5 };
            var filteredCollection = collection.WhereIf(false, x => x > 3);
            Assert.Equal(5, filteredCollection.Count);
        }

        #endregion

        #region HashSet Tests

        [Fact]
        public void WhereIf_Should_Filter_HashSet_When_Condition_True()
        {
            HashSet<int> set = new HashSet<int> { 1, 2, 3, 4, 5 };
            var filteredSet = set.WhereIf(true, x => x > 3);
            Assert.Equal(2, filteredSet.Count);
        }

        [Fact]
        public void WhereIf_Should_Not_Filter_HashSet_When_Condition_False()
        {
            HashSet<int> set = new HashSet<int> { 1, 2, 3, 4, 5 };
            var filteredSet = set.WhereIf(false, x => x > 3);
            Assert.Equal(5, filteredSet.Count);
        }

        #endregion

        #region Enumerable Tests

        [Fact]
        public void WhereIf_Should_Filter_Enumerable_When_Condition_True()
        {
            IEnumerable<int> collection = new List<int> { 1, 2, 3, 4, 5 };
            var filteredCollection = collection.WhereIf(true, x => x > 3);
            Assert.Equal(2, filteredCollection.Count());
        }

        [Fact]
        public void WhereIf_Should_Not_Filter_Enumerable_When_Condition_False()
        {
            IEnumerable<int> collection = new List<int> { 1, 2, 3, 4, 5 };
            var filteredCollection = collection.WhereIf(false, x => x > 3);
            Assert.Equal(5, filteredCollection.Count());
        }

        #endregion

        #region List Tests

        [Fact]
        public void WhereIf_Should_Filter_List_When_Condition_True()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            var filteredList = list.WhereIf(true, x => x > 3);
            Assert.Equal(2, filteredList.Count);
        }

        [Fact]
        public void WhereIf_Should_Not_Filter_List_When_Condition_False()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            var filteredList = list.WhereIf(false, x => x > 3);
            Assert.Equal(5, filteredList.Count);
        }

        #endregion

        #region Array Tests

        [Fact]
        public void WhereIf_Should_Filter_Array_When_Condition_True()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            var filteredArray = array.WhereIf(true, x => x > 3);
            Assert.Equal(2, filteredArray.Length);
        }

        [Fact]
        public void WhereIf_Should_Not_Filter_Array_When_Condition_False()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            var filteredArray = array.WhereIf(false, x => x > 3);
            Assert.Equal(5, filteredArray.Length);
        }

        #endregion
    }
}
