using System;
using System.Linq;
using System.Collections.Generic;

public class MstRepository {

    Dictionary<int, MstEntity> all;

    MstEntity[] tempArray;

    public MstRepository() {
        all = new Dictionary<int, MstEntity>();
        tempArray = new MstEntity[1000];
    }
    //增加元素
    public void Add(MstEntity entity) {
        all.Add(entity.id, entity);
    }

    // 删除
    public void Remove(MstEntity entity) {
        all.Remove(entity.id);
    }

    public int TakeAll(out MstEntity[] array) {
        all.Values.CopyTo(tempArray, 0);
        array = tempArray;
        return all.Count;
    }

}