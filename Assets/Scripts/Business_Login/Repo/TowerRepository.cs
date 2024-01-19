using System;
using System.Collections.Generic;

public class TowerRepository {
    //定义
    Dictionary<int, TowerEntity> all;

    TowerEntity[] tempArray;

// 初始化
    public TowerRepository() {
        all = new Dictionary<int, TowerEntity>();
        tempArray = new TowerEntity[20];
    }

    public void Add(TowerEntity entity) {

        all.Add(entity.id, entity);

    }

    public TowerEntity Find(Predicate<TowerEntity> predicate) {
        //遍历值
        foreach (TowerEntity Tower in all.Values) {
            bool isMacth = predicate(Tower);
            if (isMacth) {
                return Tower;
            }
        }
        return null;





    }
    public int TakeAll(out TowerEntity[] array) {
        all.Values.CopyTo(tempArray, 0);
        array = tempArray;
        return all.Count;
    }
}