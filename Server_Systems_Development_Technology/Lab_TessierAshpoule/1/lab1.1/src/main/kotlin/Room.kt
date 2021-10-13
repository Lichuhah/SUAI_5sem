data class Room(val name: String, val id: Int) {
    val listObj = mutableListOf<Obj>()

    /** колличество наименований объектов **/
    fun size() = listObj.size

    /** добавить объекты в комнату **/
    fun put(obj: Obj) {
        for (o in listObj)
            if (o.name == obj.name) {
                o.count + obj.count
                return
            }
        listObj.add(obj)
    }

    /** выгрузить объекты из комнаты **/
    fun get(name: String, count: Int) {
        for (o in listObj) {
            if ( o.name == name )
                if ( o.count < count )
                    println("Error insufficient quantity in stock")
                else
                    o.count - count
        }
    }

}