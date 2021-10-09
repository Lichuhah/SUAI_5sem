package org.suai.common.utils

import mu.KotlinLogging

/**
 * объект прокладка для вызова Klogger из java
 */
object klogger {

    /**
     * info не дать не взять
     */
    fun info(msg: () -> Any?) {
        KotlinLogging.logger { }.info {  }
    }


    /**
     * error не дать не взять
     */
    fun error(msg: () -> Any?) {
        KotlinLogging.logger { }.error {  }
    }
}