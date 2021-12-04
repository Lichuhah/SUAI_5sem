package screen

import androidx.compose.foundation.background
import androidx.compose.foundation.border
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.text.BasicTextField
import androidx.compose.material.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.setValue
import androidx.compose.runtime.getValue
import androidx.compose.runtime.remember
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.unit.dp
import repository.ProductRepository

fun checkToDouble(string: String) =
    if ("""[^\d\.]""".toRegex().containsMatchIn(string)) null
    else string

fun checkToInt(string: String) =
    if ("""[\D]""".toRegex().containsMatchIn(string) ) null
    else string

@Composable
fun productView() {
    println("productView")

    var l1 by remember { mutableStateOf(ProductRepository.data[0].limit) }
    var l2 by remember { mutableStateOf(ProductRepository.data[1].limit) }
    var l3 by remember { mutableStateOf(ProductRepository.data[2].limit) }
    var l4 by remember { mutableStateOf(ProductRepository.data[3].limit) }
    var l5 by remember { mutableStateOf(ProductRepository.data[4].limit) }
    var l6 by remember { mutableStateOf(ProductRepository.data[5].limit) }
    var l7 by remember { mutableStateOf(ProductRepository.data[6].limit) }

    var c1 by remember { mutableStateOf(ProductRepository.data[0].cost) }
    var c2 by remember { mutableStateOf(ProductRepository.data[1].cost) }
    var c3 by remember { mutableStateOf(ProductRepository.data[2].cost) }
    var c4 by remember { mutableStateOf(ProductRepository.data[3].cost) }
    var c5 by remember { mutableStateOf(ProductRepository.data[4].cost) }
    var c6 by remember { mutableStateOf(ProductRepository.data[5].cost) }
    var c7 by remember { mutableStateOf(ProductRepository.data[6].cost) }

    val tableData = (1..7).mapIndexed { index, item ->
        index to "Item $index"
    }
    val column1Weight = .3f
    val column2Weight = .3f
    val column3Weight = .4f
    LazyColumn(Modifier.fillMaxSize().padding(16.dp)) {
        // Here is the header
        item {
            Row(Modifier.background(Color.Gray)) {
                TableCell(text = "Продукт", weight = column1Weight)
                TableCell(text = "Ограничение", weight = column2Weight)
                TableCell(text = "Стоимость", weight = column3Weight)
            }
        }
        // Here are all the lines of your table.
        item {
            Row(Modifier.fillMaxWidth()) {
                TableCell(text = "1", weight = column1Weight)
                BasicTextField(
                    value = l1.toString(),
                    onValueChange = {
                        checkToInt(it)?.let { l1 = it.toInt() }
                        checkToInt(it)?.let { ProductRepository.data[0].limit = it.toInt() }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column2Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = c1.toString(),
                    onValueChange = {
                        checkToInt(it)?.let { c1 = it.toInt() }
                        checkToInt(it)?.let { ProductRepository.data[0].cost = it.toInt() }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column3Weight)
                        .padding(8.dp)
                )
            }
        }

        item {
            Row(Modifier.fillMaxWidth()) {
                TableCell(text = "2", weight = column1Weight)
                BasicTextField(
                    value = l2.toString(),
                    onValueChange = {
                        checkToInt(it)?.let { l2 = it.toInt() }
                        checkToInt(it)?.let { ProductRepository.data[1].limit = it.toInt() }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column2Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = c2.toString(),
                    onValueChange = {
                        checkToInt(it)?.let { c2 = it.toInt() }
                        checkToInt(it)?.let { ProductRepository.data[1].cost = it.toInt() }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column3Weight)
                        .padding(8.dp)
                )
            }
        }

        item {
            Row(Modifier.fillMaxWidth()) {
                TableCell(text = "3", weight = column1Weight)
                BasicTextField(
                    value = l3.toString(),
                    onValueChange = {
                        checkToInt(it)?.let { l3 = it.toInt() }
                        checkToInt(it)?.let { ProductRepository.data[2].limit = it.toInt() }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column2Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = c3.toString(),
                    onValueChange = {
                        checkToInt(it)?.let { c3 = it.toInt() }
                        checkToInt(it)?.let { ProductRepository.data[2].cost = it.toInt() }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column3Weight)
                        .padding(8.dp)
                )
            }
        }

        item {
            Row(Modifier.fillMaxWidth()) {
                TableCell(text = "4", weight = column1Weight)
                BasicTextField(
                    value = l4.toString(),
                    onValueChange = {
                        checkToInt(it)?.let { l4 = it.toInt() }
                        checkToInt(it)?.let { ProductRepository.data[3].limit = it.toInt() }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column2Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = c4.toString(),
                    onValueChange = {
                        checkToInt(it)?.let { c4 = it.toInt() }
                        checkToInt(it)?.let { ProductRepository.data[3].cost = it.toInt() }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column3Weight)
                        .padding(8.dp)
                )
            }
        }
        item {
            Row(Modifier.fillMaxWidth()) {
                TableCell(text = "5", weight = column1Weight)
                BasicTextField(
                    value = l5.toString(),
                    onValueChange = {
                        checkToInt(it)?.let { l5 = it.toInt() }
                        checkToInt(it)?.let { ProductRepository.data[4].limit = it.toInt() }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column2Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = c5.toString(),
                    onValueChange = {
                        checkToInt(it)?.let { c5 = it.toInt() }
                        checkToInt(it)?.let { ProductRepository.data[4].cost = it.toInt() }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column3Weight)
                        .padding(8.dp)
                )
            }
        }

        item {
            Row(Modifier.fillMaxWidth()) {
                TableCell(text = "6", weight = column1Weight)
                BasicTextField(
                    value = l6.toString(),
                    onValueChange = {
                        checkToInt(it)?.let { l6 = it.toInt() }
                        checkToInt(it)?.let { ProductRepository.data[5].limit = it.toInt() }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column2Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = c6.toString(),
                    onValueChange = {
                        checkToInt(it)?.let { c6 = it.toInt() }
                        checkToInt(it)?.let { ProductRepository.data[5].cost = it.toInt() }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column3Weight)
                        .padding(8.dp)
                )
            }
        }

        item {
            Row(Modifier.fillMaxWidth()) {
                TableCell(text = "7", weight = column1Weight)
                BasicTextField(
                    value = l7.toString(),
                    onValueChange = {
                        checkToInt(it)?.let { l7 = it.toInt() }
                        checkToInt(it)?.let { ProductRepository.data[6].limit = it.toInt() }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column2Weight)
                        .padding(8.dp)
                )
                BasicTextField(
                    value = c7.toString(),
                    onValueChange = {
                        checkToInt(it)?.let { c7 = it.toInt() }
                        checkToInt(it)?.let { ProductRepository.data[6].cost = it.toInt() }
                    },
                    Modifier
                        .border(1.dp, Color.Black)
                        .weight(column3Weight)
                        .padding(8.dp)
                )
            }
        }
    }
}

@Composable
fun RowScope.TableCell(
    text: String,
    weight: Float
) {
    Text(
        text = text,
        Modifier
            .border(1.dp, Color.Black)
            .weight(weight)
            .padding(8.dp)
    )
}
