//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Script: ./scripts/cldr-relative-time.csx
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Alrev.Intl.Abstractions;
using Alrev.Intl.Abstractions.RelativeTime;
using System;

namespace Alrev.Intl.RelativeTime.Resources
{
    public class SpanishChileRelativeTimeResourceSet : IRelativeTimeResourceSet, IResource
    {
        private const string LOCALE = "es-CL";
        public string Locale { get; } = LOCALE;

        public IRelativeTimeStylesResource Era { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "era",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "era",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "era",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Year { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "año",
                "el año pasado",
                "este año",
                "el próximo año",
                new RelativeTimeCountResource("hace {0} año", "hace {0} años"),
                new RelativeTimeCountResource("dentro de {0} año", "dentro de {0} años")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "a",
                "el año pasado",
                "este año",
                "el próximo año",
                new RelativeTimeCountResource("hace {0} a", "hace {0} a"),
                new RelativeTimeCountResource("dentro de {0} a", "dentro de {0} a")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "a",
                "el año pasado",
                "este año",
                "el próximo año",
                new RelativeTimeCountResource("hace {0} a", "hace {0} a"),
                new RelativeTimeCountResource("dentro de {0} a", "dentro de {0} a")));

        public IRelativeTimeStylesResource Quarter { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "trimestre",
                "el trimestre pasado",
                "este trimestre",
                "el próximo trimestre",
                new RelativeTimeCountResource("hace {0} trimestre", "hace {0} trimestres"),
                new RelativeTimeCountResource("dentro de {0} trimestre", "dentro de {0} trimestres")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "trim.",
                "el trimestre pasado",
                "este trimestre",
                "el próximo trimestre",
                new RelativeTimeCountResource("hace {0} trim.", "hace {0} trim."),
                new RelativeTimeCountResource("dentro de {0} trim.", "dentro de {0} trim.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "trim.",
                "el trimestre pasado",
                "este trimestre",
                "el próximo trimestre",
                new RelativeTimeCountResource("hace {0} trim.", "hace {0} trim."),
                new RelativeTimeCountResource("dentro de {0} trim.", "dentro de {0} trim.")));

        public IRelativeTimeStylesResource Month { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "mes",
                "el mes pasado",
                "este mes",
                "el próximo mes",
                new RelativeTimeCountResource("hace {0} mes", "hace {0} meses"),
                new RelativeTimeCountResource("dentro de {0} mes", "dentro de {0} meses")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "m",
                "el mes pasado",
                "este mes",
                "el próximo mes",
                new RelativeTimeCountResource("hace {0} m", "hace {0} m"),
                new RelativeTimeCountResource("dentro de {0} m", "dentro de {0} m")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "m",
                "el mes pasado",
                "este mes",
                "el próximo mes",
                new RelativeTimeCountResource("hace {0} m", "hace {0} m"),
                new RelativeTimeCountResource("dentro de {0} m", "dentro de {0} m")));

        public IRelativeTimeStylesResource Week { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "semana",
                "la semana pasada",
                "esta semana",
                "la próxima semana",
                new RelativeTimeCountResource("hace {0} semana", "hace {0} semanas"),
                new RelativeTimeCountResource("dentro de {0} semana", "dentro de {0} semanas")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "sem.",
                "sem. pas.",
                "esta sem.",
                "próx. sem.",
                new RelativeTimeCountResource("hace {0} sem.", "hace {0} sem."),
                new RelativeTimeCountResource("dentro de {0} sem.", "dentro de {0} sem.")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sem.",
                "sem. pas.",
                "esta sem.",
                "próx. sem.",
                new RelativeTimeCountResource("hace {0} sem.", "hace {0} sem."),
                new RelativeTimeCountResource("dentro de {0} sem.", "dentro de {0} sem.")));

        public IRelativeTimeStylesResource WeekOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "semana del mes",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "sem. del mes",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "sem. del mes",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Day { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "día",
                "ayer",
                "hoy",
                "mañana",
                new RelativeTimeCountResource("hace {0} día", "hace {0} días"),
                new RelativeTimeCountResource("dentro de {0} día", "dentro de {0} días")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "d",
                "ayer",
                "hoy",
                "mañana",
                new RelativeTimeCountResource("hace {0} día", "hace {0} días"),
                new RelativeTimeCountResource("dentro de {0} día", "dentro de {0} días")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "d",
                "ayer",
                "hoy",
                "mañana",
                new RelativeTimeCountResource("hace {0} día", "hace {0} días"),
                new RelativeTimeCountResource("dentro de {0} día", "dentro de {0} días")));

        public IRelativeTimeStylesResource DayOfYear { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "día del año",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "día del año",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "día del año",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Weekday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "día de la semana",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "día de sem.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "día de sem.",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource WeekdayOfMonth { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "día hábil del mes",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "día hábil del mes",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "día hábil del mes",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Sunday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "el domingo pasado",
                "este domingo",
                "el próximo domingo",
                new RelativeTimeCountResource("hace {0} domingo", "hace {0} domingos"),
                new RelativeTimeCountResource("en {0} domingo", "en {0} domingos")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "el DO pasado",
                "este DO",
                "el próximo DO",
                new RelativeTimeCountResource("hace {0} DO", "hace {0} DO"),
                new RelativeTimeCountResource("dentro de {0} DO", "dentro de {0} DO")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "el dom. pasado",
                "este dom.",
                "el próximo dom.",
                new RelativeTimeCountResource("hace {0} dom.", "hace {0} dom."),
                new RelativeTimeCountResource("dentro de {0} dom.", "dentro de {0} dom.")));

        public IRelativeTimeStylesResource Monday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "el lunes pasado",
                "este lunes",
                "el próximo lunes",
                new RelativeTimeCountResource("hace {0} lunes", "hace {0} lunes"),
                new RelativeTimeCountResource("dentro de {0} lunes", "dentro de {0} lunes")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "el LU pasado",
                "este LU",
                "el próximo LU",
                new RelativeTimeCountResource("hace {0} LU", "hace {0} LU"),
                new RelativeTimeCountResource("dentro de {0} LU", "dentro de {0} LU")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "el lun. pasado",
                "este lun.",
                "el próximo lun.",
                new RelativeTimeCountResource("hace {0} lun.", "hace {0} lun."),
                new RelativeTimeCountResource("dentro de {0} lun.", "dentro de {0} lun.")));

        public IRelativeTimeStylesResource Tuesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "el martes pasado",
                "este martes",
                "el próximo martes",
                new RelativeTimeCountResource("hace {0} martes", "hace {0} martes"),
                new RelativeTimeCountResource("dentro de {0} martes", "en {0} martes")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "el MA pasado",
                "este MA",
                "el próximo MA",
                new RelativeTimeCountResource("hace {0} MA", "hace {0} MA"),
                new RelativeTimeCountResource("dentro de {0} MA", "dentro de {0} MA")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "el mar. pasado",
                "este mar.",
                "el próximo mar.",
                new RelativeTimeCountResource("hace {0} mar.", "hace {0} mar."),
                new RelativeTimeCountResource("dentro de {0} mar.", "dentro de {0} mar.")));

        public IRelativeTimeStylesResource Wednesday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "el miércoles pasado",
                "este miércoles",
                "el próximo miércoles",
                new RelativeTimeCountResource("hace {0} miércoles", "hace {0} miércoles"),
                new RelativeTimeCountResource("dentro de {0} miércoles", "dentro de {0} miércoles")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "el MI pasado",
                "este MI",
                "el próximo MI",
                new RelativeTimeCountResource("hace {0} MI", "hace {0} MI"),
                new RelativeTimeCountResource("dentro de {0} MI", "dentro de {0} MI")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "el mié. pasado",
                "este mié.",
                "el próximo mié.",
                new RelativeTimeCountResource("hace {0} mié.", "hace {0} mié."),
                new RelativeTimeCountResource("dentro de {0} mié.", "dentro de {0} mié.")));

        public IRelativeTimeStylesResource Thursday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "el jueves pasado",
                "este jueves",
                "el próximo jueves",
                new RelativeTimeCountResource("hace {0} jueves", "hace {0} jueves"),
                new RelativeTimeCountResource("dentro de {0} jueves", "dentro de {0} jueves")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "el JU pasado",
                "este JU",
                "el próximo JU",
                new RelativeTimeCountResource("hace {0} JU", "hace {0} JU"),
                new RelativeTimeCountResource("dentro de {0} JU", "dentro de {0} JU")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "el jue. pasado",
                "este jue.",
                "el próximo jue.",
                new RelativeTimeCountResource("hace {0} jue.", "hace {0} jue."),
                new RelativeTimeCountResource("dentro de {0} jue.", "dentro de {0} jue.")));

        public IRelativeTimeStylesResource Friday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "el viernes pasado",
                "este viernes",
                "el próximo viernes",
                new RelativeTimeCountResource("hace {0} viernes", "hace {0} viernes"),
                new RelativeTimeCountResource("dentro de {0} viernes", "dentro de {0} viernes")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "el VI pasado",
                "este VI",
                "el próximo VI",
                new RelativeTimeCountResource("hace {0} viernes", "hace {0} viernes"),
                new RelativeTimeCountResource("dentro de {0} VI", "dentro de {0} VI")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "el vie. pasado",
                "este vie.",
                "el próximo vie.",
                new RelativeTimeCountResource("hace {0} viernes", "hace {0} viernes"),
                new RelativeTimeCountResource("dentro de {0} vie.", "dentro de {0} vie.")));

        public IRelativeTimeStylesResource Saturday { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                null,
                "el sábado pasado",
                "este sábado",
                "el próximo sábado",
                new RelativeTimeCountResource("hace {0} sábado", "hace {0} sábados"),
                new RelativeTimeCountResource("dentro de {0} sábado", "dentro de {0} sábados")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                null,
                "el SA pasado",
                "este SA",
                "el próximo SA",
                new RelativeTimeCountResource("hace {0} sábados", "hace {0} sábados"),
                new RelativeTimeCountResource("dentro de {0} SA", "dentro de {0} SA")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                null,
                "el sáb. pasado",
                "este sáb.",
                "el próximo sáb.",
                new RelativeTimeCountResource("hace {0} sáb.", "hace {0} sáb."),
                new RelativeTimeCountResource("dentro de {0} sáb.", "dentro de {0} sáb.")));

        public IRelativeTimeStylesResource DayPeriod { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "a. m./p. m.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "a.m./p.m.",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "a.m./p.m.",
                null,
                null,
                null,
                null,
                null));

        public IRelativeTimeStylesResource Hour { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "hora",
                null,
                "esta hora",
                null,
                new RelativeTimeCountResource("hace {0} hora", "hace {0} horas"),
                new RelativeTimeCountResource("dentro de {0} hora", "dentro de {0} horas")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "h",
                null,
                "esta hora",
                null,
                new RelativeTimeCountResource("hace {0} h", "hace {0} h"),
                new RelativeTimeCountResource("dentro de {0} h", "dentro de {0} h")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "h",
                null,
                "esta hora",
                null,
                new RelativeTimeCountResource("hace {0} h", "hace {0} h"),
                new RelativeTimeCountResource("dentro de {0} h", "dentro de {0} h")));

        public IRelativeTimeStylesResource Minute { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "minuto",
                null,
                "este minuto",
                null,
                new RelativeTimeCountResource("hace {0} minuto", "hace {0} minutos"),
                new RelativeTimeCountResource("dentro de {0} minuto", "dentro de {0} minutos")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "min",
                null,
                "este minuto",
                null,
                new RelativeTimeCountResource("hace {0} min", "hace {0} min"),
                new RelativeTimeCountResource("dentro de {0} min", "dentro de {0} min")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "min",
                null,
                "este minuto",
                null,
                new RelativeTimeCountResource("hace {0} min", "hace {0} min"),
                new RelativeTimeCountResource("dentro de {0} min", "dentro de {0} min")));

        public IRelativeTimeStylesResource Second { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "segundo",
                null,
                "ahora",
                null,
                new RelativeTimeCountResource("hace {0} segundo", "hace {0} segundos"),
                new RelativeTimeCountResource("dentro de {0} segundo", "dentro de {0} segundos")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "s",
                null,
                "ahora",
                null,
                new RelativeTimeCountResource("hace {0} s", "hace {0} s"),
                new RelativeTimeCountResource("dentro de {0} s", "dentro de {0} s")),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "s",
                null,
                "ahora",
                null,
                new RelativeTimeCountResource("hace {0} s", "hace {0} s"),
                new RelativeTimeCountResource("dentro de {0} s", "dentro de {0} s")));

        public IRelativeTimeStylesResource Zone { get; } = new RelativeTimeStylesResource(
            LOCALE,
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Long,
                "zona horaria",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Narrow,
                "zona",
                null,
                null,
                null,
                null,
                null),
            new RelativeTimeResource(
                LOCALE,
                RelativeTimeTypeValues.Short,
                "zona",
                null,
                null,
                null,
                null,
                null));
    }
}