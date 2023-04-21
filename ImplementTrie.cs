using System;
using System.Collections.Generic;
namespace Algo
{

    public class TrieNode
    {
        public char c;
        public Dictionary<char, TrieNode> dict = new Dictionary<char, TrieNode>();
        public bool isLastNode;

        public TrieNode(char c)
        {
            this.c = c;
        }
    }
    public class Trie
    {

        TrieNode root;
        public Trie()
        {
            root = new TrieNode('\0');
        }

        public void Insert(string word)
        {
            TrieNode p = root;
            foreach (char c in word)
            {
                if (p.dict.ContainsKey(c))
                {
                    p = p.dict[c];
                }
                else
                {
                    p.dict[c] = new TrieNode(c);
                    p = p.dict[c];
                }
            }
            p.isLastNode = true;
        }

        public bool Search(string word)
        {

            TrieNode p = root;
            foreach (char c in word)
            {
                if (!p.dict.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    p = p.dict[c];
                }
            }
            return p.isLastNode;

        }

        public bool StartsWith(string prefix)
        {
            TrieNode p = root;
            foreach (char c in prefix)
            {
                if (!p.dict.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    p = p.dict[c];
                }
            }
            return true;

        }
    }

    public class ImplementTrie
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.Insert("apple");
            System.Console.WriteLine(trie.Search("apple"));  // return True
            System.Console.WriteLine(trie.Search("app"));     // return False
            System.Console.WriteLine(trie.StartsWith("app")); // return True
            trie.Insert("app");
            System.Console.WriteLine(trie.Search("app"));     // True
        }
    }
}