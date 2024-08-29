using NUnit.Framework;
using UnityEngine;

public class SimpleDebugTest
{
    [Test]
    public void CheckConditionWithDebugLog()
    {
        // Supongamos que tienes una función que devuelve un valor booleano
        bool IsConditionMet() => true; // ¡Puedes cambiar esto según tu lógica!

        // Verifica si la condición está cumplida
        bool conditionResult = IsConditionMet();

        // Muestra un mensaje en la consola con Debug.Log
        Debug.Log($"La condición es: {conditionResult}");

        // Verifica si la condición es verdadera (puedes ajustar esto según tus necesidades)
        Assert.IsTrue(conditionResult);
    }
}