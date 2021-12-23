package screen

import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.material.Button
import androidx.compose.material.Text
import androidx.compose.material.TextField
import androidx.compose.runtime.*
import repository.LineRepository

@Composable
fun lineView() {
    println("lineView")
    var viewLine by remember { mutableStateOf(0) }

    var name  by remember { mutableStateOf(LineRepository.data[viewLine].name)  }
    var count by remember { mutableStateOf(LineRepository.data[viewLine].count) }
    var tp1   by remember { mutableStateOf(LineRepository.data[viewLine].tp1)   }
    var tp2   by remember { mutableStateOf(LineRepository.data[viewLine].tp2)   }
    var tp3   by remember { mutableStateOf(LineRepository.data[viewLine].tp3)   }
    var tp4   by remember { mutableStateOf(LineRepository.data[viewLine].tp4)   }
    var tp5   by remember { mutableStateOf(LineRepository.data[viewLine].tp5)   }
    var tp6   by remember { mutableStateOf(LineRepository.data[viewLine].tp6)   }
    var tp7   by remember { mutableStateOf(LineRepository.data[viewLine].tp7)   }
    var cost  by remember { mutableStateOf(LineRepository.data[viewLine].cost)  }

    Column {
        Row {
            for (i in 1..5) {
                Button(
                    onClick = {
                        println("onClick $i")
                        viewLine = i-1
                        name = LineRepository.data[viewLine].name
                        count = LineRepository.data[viewLine].count
                        tp1 = LineRepository.data[viewLine].tp1
                        tp2 = LineRepository.data[viewLine].tp2
                        tp3 = LineRepository.data[viewLine].tp3
                        tp4 = LineRepository.data[viewLine].tp4
                        tp5 = LineRepository.data[viewLine].tp5
                        tp6 = LineRepository.data[viewLine].tp6
                        tp7 = LineRepository.data[viewLine].tp7
                        cost = LineRepository.data[viewLine].cost
                    },
                    content = {
                        Text("Линия $i")
                    }
                )
            }
        }

        Column {
            TextField(
                label = { Text("Название") },
                value = name,
                onValueChange = {
                    name = it
                    LineRepository.data[viewLine].name = it
                },
            )
            TextField(
                label = { Text("Колличество линий") },
                value = count.toString(),
                onValueChange = {
                    count = it.toInt()
                    LineRepository.data[viewLine].count = it.toInt()
                }
            )
            TextField(
                label = { Text("Время производства продукта 1") },
                value = tp1.toString(),
                onValueChange = {
                    tp1 = it.toDouble()
                    LineRepository.data[viewLine].tp1 = it.toDouble()
                }
            )
            TextField(
                label = { Text("Время производства продукта 2") },
                value = tp2.toString(),
                onValueChange = {
                    tp2 = it.toDouble()
                    LineRepository.data[viewLine].tp2 = it.toDouble()
                }
            )
            TextField(
                label = { Text("Время производства продукта 3") },
                value = tp3.toString(),
                onValueChange = {
                    tp3 = it.toDouble()
                    LineRepository.data[viewLine].tp3 = it.toDouble() }
            )
            TextField(
                label = { Text("Время производства продукта 4") },
                value = tp4.toString(),
                onValueChange = {
                    tp4 = it.toDouble()
                    LineRepository.data[viewLine].tp4 = it.toDouble() }
            )
            TextField(
                label = { Text("Время производства продукта 5") },
                value = tp5.toString(),
                onValueChange = {
                    tp5 = it.toDouble()
                    LineRepository.data[viewLine].tp5 = it.toDouble() }
            )
            TextField(
                label = { Text("Время производства продукта 6") },
                value = tp6.toString(),
                onValueChange = {
                    tp6 = it.toDouble()
                    LineRepository.data[viewLine].tp6 = it.toDouble() }
            )
            TextField(
                label = { Text("Время производства продукта 7") },
                value = tp7.toString(),
                onValueChange = { tp7 = it.toDouble()
                    LineRepository.data[viewLine].tp7 = it.toDouble() }
            )
            TextField(
                label = { Text("Цена") },
                value = cost.toString(),
                onValueChange = {
                    cost = it.toDouble()
                    LineRepository.data[viewLine].cost = it.toDouble() }
            )
        }
    }
}
