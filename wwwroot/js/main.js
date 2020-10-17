var map;
var marker
DG.then(function() {
    

    map = DG.map('map', {
        center: [54.514, 36.260],
        zoom: 9,
        fullscreenControl: false,
        zoomControl: false,
        poi: false
    });

    map.locate({setView: true, watch: false})
        .on('locationfound', function (e)
        {
            marker = DG.marker([e.latitude, e.longitude]).addTo(map);    
            Card_Pos_X.value = e.latlng.lat;
            Card_Pos_Y.value = e.latlng.lng;
        })
        .on('locationerror', function(e) {
            DG.popup()
              .setLatLng(map.getCenter())
              .setContent('Доступ к определению местоположения отключён')
              .openOn(map);
        });

    map.on('click', function (e) {
        marker.setLatLng([e.latlng.lat, e.latlng.lng]);
        Card_Pos_X.value = e.latlng.lat;
        Card_Pos_Y.value = e.latlng.lng;
    });
});