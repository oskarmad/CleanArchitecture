using ClearArchitecture.Domain.Abstractions;

namespace ClearArchitecture.Domain.Reviews;

public static class ReviewErrors
{

    public static readonly Error NotEligible = new(
        "Review.NotEligible",
        "Este review y calificacion para el auto no es elegible por que aun no se completa"
    );


}