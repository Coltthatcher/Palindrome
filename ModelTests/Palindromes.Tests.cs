using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

namespace Palindromes.Test
{
  [TestClass]
  public class PalindromeTest
  {
    [TestMethod]
    public void IsItPalindrome_CompareRevWord_False()
    {
      Palindrome testPalindromes = new Palindrome();
      Assert.AreEqual(false, testPalindromes.IsItPalindrome("olleh", "hello"));
    }

    [TestMethod]

    public void IsReverse_CheckIfWordIsArray_Char()
    {
      Palindrome testPalindromes = new Palindrome();
      Assert.AreEqual(new char[]{'c','a','t'}, testPalindromes.IsReverse("cat"));
    }
  }
}
