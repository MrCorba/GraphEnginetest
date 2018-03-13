using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphEngineModels;
using Trinity;


namespace GraphServer
{
    public class WordsStore : GraphEngineModels.WordsStoreBase
    {
        public override void GetHandler(GetRequest request, out Word response)
        {
            try
            {
                response = Global.LocalStorage.LoadWord(request.word_id);
            }
            catch
            {
                response = new Word(description: "");
            }
        }

        public override void CreateHandler(CreateRequest request, out Word response)
        {
            Word newWord = new Word(description: request.word);

            Global.LocalStorage.SaveWord(newWord);

            response = newWord;
        }
    }
}
