﻿using Business.Abstract;
using Business.Constants;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult("Kategori başarıyla eklendi");
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult("Kategori başarıyla silindi");
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c=>c.CategoryId == categoryId));
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult("Araba başarıyla güncellendi");
        }
    }
}
