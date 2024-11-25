abstract class PizzaCity( val neapolitanPizzaPrice:Double, val romanPizzaPrice: Double,
    val sicilianPizzaPrice:Double, val tyroleanPizzaPrice:Double)
{
   var neapolitanPizzaCount=0
   var romanPizzaCount=0
   var sicilianPizzaCount=0
   var tyropleanPizzaCount=0

    abstract fun neapolitanPizzaSale()

    abstract fun romanPizzaSale()

    abstract fun sicilianPizzaSale()

    abstract fun tyroleanPizzaSale()

    fun showStatistics()
    {
        println("Продано сицилийской пиццы: $sicilianPizzaCount")
        println("Продано неаполитанской пиццы: $neapolitanPizzaCount")
        println("Продано римской пиццы: $romanPizzaCount")
        println("Продано тирольской пиццы: $tyropleanPizzaCount")

        val money=neapolitanPizzaCount*neapolitanPizzaPrice + romanPizzaCount*romanPizzaPrice+sicilianPizzaCount*sicilianPizzaPrice+tyropleanPizzaCount*tyroleanPizzaPrice
        println("Всего заработано денег: $money")
    }

}