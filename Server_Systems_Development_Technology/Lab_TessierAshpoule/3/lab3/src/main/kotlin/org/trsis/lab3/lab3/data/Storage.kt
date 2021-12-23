package com.example.demo.data

object Storage {
    val data = storageData()

    /** колличество комнат **/
    fun size() = data.roomList.size

    /** добавление комнаты на склад
     * true - успешное добавлени**/
    fun addRoom(name: String, id: Int): Boolean {
        if (name.isNotEmpty() && id >= 0) {
            for (r in data.roomList)
                if (r.name == name || r.id == id) {
                    erroreStorage.error("Error room with such data already exists")
                    return false
                }
            data.roomList.add(Room(name, id))
            return true
        } else {
            erroreStorage.error("Error directional data about the room")
            return false
        }
    }

    /** удаление комнаты **/
    fun deleteRoom(id: Int): Boolean {
        for (i in 0 until data.roomList.size) {
            if (data.roomList[i].id == id) {
                data.roomList.removeAt(i)
                return true
            }
        }
        erroreStorage.error("Error this room not found")
        return false
    }

}