﻿${
    // Enable extension methods by adding using Typewriter.Extensions.*
    using Typewriter.Extensions.Types;	
}
module Models {

    $Classes(PlanetWars.Models.*)[
    export interface I$Name {
        $Properties[
        $name: $Type;]
    }]
}