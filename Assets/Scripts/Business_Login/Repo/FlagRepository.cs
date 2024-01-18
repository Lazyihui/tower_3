using System;
using System.Collections.Generic;

public class FlagRepository {
    //定义
    Dictionary<int, FlagEntity> all;

    FlagEntity[] tempArray;

// 初始化
    public FlagRepository() {
        all = new Dictionary<int, FlagEntity>();
        tempArray = new FlagEntity[20];
    }

    public void Add(FlagEntity entity) {

        all.Add(entity.id, entity);

    }

    public FlagEntity Find(Predicate<FlagEntity> predicate) {
        //遍历值
        foreach (FlagEntity flag in all.Values) {
            bool isMacth = predicate(flag);
            if (isMacth) {
                return flag;
            }
        }
        return null;
    }
    public int TakeAll(out FlagEntity[] array) {
        all.Values.CopyTo(tempArray, 0);
        array = tempArray;
        return all.Count;
    }
}