var map;
DG.then(function() {
    

    map = DG.map('map', {
        center: [54.514, 36.260],
        zoom: 9,
        fullscreenControl: false,
        zoomControl: false
    });

    map.locate({setView: true, watch: true})
        .on('locationfound', function(e) {
          	info.innerHTML=`Широта в градусах.: ${e.latlng.lat} </br>
    	Долгота в градусах.: ${e.latlng.lng} </br>
    	Высота в метрах (опционально).: ${e.latlng.alt} </br>
		Точность определения местоположения в метрах.: ${e.accuracy} </br>
		Высота над поверхностью земли в метрах, согласно координатной системе WGS84.: ${e.altitude} </br>
		Точность определения высоты в метрах.: ${e.altitudeAccuracy	} </br>
		Направление движения в градусах, считается с севера, в направлении по часовой стрелке.: ${e.heading} </br>
		Скорость в метрах в секунду.: ${e.speed	} </br>
		Момент времени измерения местоположения.: ${e.timestamp} </br>
    	`;	
        })
        .on('locationerror', function(e) {
            DG.popup()
              .setLatLng(map.getCenter())
              .setContent('Доступ к определению местоположения отключён')
              .openOn(map);
        });

    map.on('click', function(e){
    	info.innerHTML=`Широта в градусах.: ${e.latlng.lat} </br>
    	Долгота в градусах.
: ${e.latlng.lng} </br>
    	Высота в метрах (опционально).
: ${e.latlng.alt} </br>
    	Широта в градусах.: ${e.latlng.lat} </br>
    	Широта в градусах.: ${e.latlng.lat} </br>
    	Широта в градусах.: ${e.latlng.lat} </br>
    	Широта в градусах.: ${e.latlng.lat} </br>
    	Широта в градусах.: ${e.latlng.lat} </br>
    	Широта в градусах.: ${e.latlng.lat} </br>
    	Широта в градусах.: ${e.latlng.lat} </br>`;
    });
});