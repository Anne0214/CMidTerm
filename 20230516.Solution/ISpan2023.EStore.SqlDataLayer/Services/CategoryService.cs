using ISpan2023.EStore.SqlDataLayer.Dtos;
using ISpan2023.EStore.SqlDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan2023.EStore.SqlDataLayer.Services
{
	public class CategoryService
	{
		public int Create(CategoryDto dto) {
			//precondition checks, 檢查各欄位值是否有填寫正確

			// 驗證分類名稱是否有重覆
			var repo = new CategoryRepository();
			var dtoInDb = repo.GetByName(dto.Name);
			if (dtoInDb != null) {
				throw new Exception("抱歉, 此分類名稱已存在,無法新增");
			}

			// 建立一筆新記錄
			int newId = repo.Create(dto);

			return newId;		
		}

		public int Update(CategoryDto dto)
		{
			//precondition checks, 檢查各欄位值是否有填寫正確

			// 驗證分類名稱是否有重覆
			var repo = new CategoryRepository();
			var dtoInDb = repo.GetByName(dto.Name);
			if (dtoInDb != null && dtoInDb.Id !=dto.Id)
			{
				throw new Exception("抱歉, 此分類名稱已存在,無法更新");
			}

			// 更新記錄
			int rows = repo.Update(dto);

			return rows;
		}
	}
}
