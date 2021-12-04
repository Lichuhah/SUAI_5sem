package repository

import Data.Line

object LineRepository {
    val data = mutableListOf<Line>()

    fun add(line: Line?) =
        if (line != null) {
            if ( data.size == 5 )
                for (d in 0..4)
                    if (data[d].name == line.name)
                        data[d] = line
            data.add(line)
        }
        else
            false
}