using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace card_game_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Card_class()
        {
            Card actual = new Card("Hearts", 1);
            Card expected = new Card("Spade", 1);
            Assert.AreEqual(actual.GetType(), expected.GetType());
        }

        [Test]
        public void Test_Card_Deck_Size()
        {
            int actual_number = new Deck().cards.Count;
            Assert.AreEqual(52, actual_number);
        }

        [Test]
        public void Test_draw_by_color()
        {
            Deck d = new Deck();
            d.Draw();
            // get last values and it should be Spades, 12. 
            string color = d.cards.LastOrDefault().color;
            Assert.AreEqual("Spades", color);
        }

        [Test]
        public void Test_draw_by_value()
        {
            Deck d = new Deck();
            d.Draw();
            // get last values and it should be Spades, 12. 
            int value = d.cards.LastOrDefault().value;
            Assert.AreEqual(12, value);
        }
        [Test]
        public void Test_draw_by_length()
        {
            Deck d = new Deck();
            d.Draw();
            // length should be 51 after one card draw
            Assert.AreEqual(51, d.cards.Count);
        }
        [Test]
        public void test_shuffle_method()
        {
            Assert.Pass();
        }
        [Test]
        public void test_sort_method()
        {
            Assert.Pass();
        }
    }
}