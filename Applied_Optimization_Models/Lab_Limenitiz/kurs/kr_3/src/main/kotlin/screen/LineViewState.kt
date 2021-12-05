package screen

import androidx.compose.runtime.MutableState

data class LineViewState(
    val name : MutableState<String>,
    val count: MutableState<Int>,
    val tp: List<MutableState<Double>>,
    val cost : MutableState<Double>
)
{}