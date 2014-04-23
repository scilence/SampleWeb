using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace SampleWeb.Entities
{
    /// <summary>
    /// 筆記
    /// </summary>
    [Table(Name = "Memo")]
    public class Memo
    {
        [Column(Name = "ID", IsPrimaryKey = true)]
        public string ID { get; set; }

        [Column(Name = "Title")]
        public string Title { get; set; }

        [Column(Name = "Content")]
        public string Content { get; set; }

        [Column(Name = "Creater")]
        public string Creater { get; set; }

        [Column(Name = "Updater", CanBeNull=true)]
        public string Updater { get; set; }

        [Column(Name = "CreatedTime")]
        public DateTime CreatedTime { get; set; }

        [Column(Name = "UpdatedTime", CanBeNull = true)]
        public DateTime? UpdatedTime { get; set; }


        #region Methods

        public static Memo Get(DataContext context, string id)
        {
            var memos = context.GetTable<Memo>();
            var query = from memo in memos
                        where memo.ID == id
                        select memo;

            foreach (var it in query)
            {
                return it;
            }

            return null;
        }

        public static IList<Memo> ListAll(DataContext context)
        {
            var memos = context.GetTable<Memo>();
            var query = from memo in memos
                        select memo;
            return query.ToList();
        }

        public static void Add(DataContext context, Memo memo)
        {
            memo.ID = Guid.NewGuid().ToString();

            var memos = context.GetTable<Memo>();
            memos.InsertOnSubmit(memo);
        }

        #endregion

    }
}