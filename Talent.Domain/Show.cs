using System;
using System.Collections.Generic;
using UclaExt.Common.BaseClasses;
using UclaExt.Common.Interfaces;

namespace Talent.Domain
{
    public class Show : DomainBase, IDisplayable
    {
        #region Constructor

        #endregion

        #region Fields

        private int _id;
        private string _title;
        private int? _lengthInMinutes;
        private DateTime? _releaseDate;
        private int? _mpaaRatingId;
        private List<ShowGenre> _showGenres = new List<ShowGenre>();
        private List<Credit> _credits = new List<Credit>();

        #endregion

        #region Properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (_title == value) return;
                _title = value;
                OnPropertyChanged();
            }
        }

        public int? LengthInMinutes
        {
            get { return _lengthInMinutes; }
            set
            {
                if (_lengthInMinutes == value) return;
                _lengthInMinutes = value;
                OnPropertyChanged();
            }
        }

        public DateTime? ReleaseDate
        {
            get { return _releaseDate; }
            set
            {
                if (_releaseDate == value) return;
                _releaseDate = value;
                OnPropertyChanged();
            }
        }

        public int? MpaaRatingId
        {
            get { return _mpaaRatingId; }
            set
            {
                if (_mpaaRatingId == value) return;
                _mpaaRatingId = value;
                OnPropertyChanged();
            }
        }

        public List<ShowGenre> ShowGenres
        {
            get { return _showGenres; }
        }

        public List<Credit> Credits
        {
            get { return _credits; }
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return Title;
        }



        #endregion

        #region IDisplayable

        public string Display()
        {
            string msg = Title ?? "";
            if(ReleaseDate.HasValue)
            {
                msg += "(" + ReleaseDate.Value.Year + ")";
            }
            return msg;
        }

        #endregion
    }

}
