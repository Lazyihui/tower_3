using System;
using System.Collections.Generic;

public class MoveRepository {
    //定义
    Dictionary<int, MoveEntity> all;

    MoveEntity[] tempArray;

    // 初始化
    public MoveRepository() {
        all = new Dictionary<int, MoveEntity>();
        tempArray = new MoveEntity[20];
    }

    public void Add(MoveEntity entity) {

        all.Add(entity.id, entity);

    }

    public MoveEntity Find(Predicate<MoveEntity> predicate) {
        //遍历值
        foreach (MoveEntity flag in all.Values) {
            bool isMacth = predicate(flag);
            if (isMacth) {
                return flag;
            }
        }
        return null;
    }
    public int TakeAll(out MoveEntity[] array) {
        all.Values.CopyTo(tempArray, 0);
        array = tempArray;
        return all.Count;
    }
}