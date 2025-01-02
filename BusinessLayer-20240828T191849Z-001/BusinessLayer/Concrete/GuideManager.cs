﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public Guide GetByID(int id)
        {
            return _guideDal.GetByID(id); 
        }

        public void TAdd(Guide t)
        {
           _guideDal.Insert(t);
        }

        public void TChangeToFalseByGuide(int id)
        {
           _guideDal.ChangeToFalseByGuide(id);
        }

        public void TChangeToTrueByGuide(int id)
        {
            _guideDal.ChangeToTrueByGuide(id);
        }

        public void TDelete(Guide t)
        {
             _guideDal.Delete(t);
        }

        public List<Guide> TGetList()
        {
           return _guideDal.GetList();
        }

        public void Tupdate(Guide t)
        {
            _guideDal.Update(t);
        }
    }
}
