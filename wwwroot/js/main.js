var map;
var marker;
var x;
var y;

DG.then(function() {
    

    map = DG.map('map', {
        center: [54.514, 36.260],
        zoom: 9,
        fullscreenControl: false,
        zoomControl: false,
        poi: false
    });

    if (Card_Pos_X.value == "" & Card_Pos_Y.value == "") {
        map.locate({ setView: true, watch: false })
            .on('locationfound', function (e) {
                x = e.latlng.lat;
                y = e.latlng.lng;
                Card_Pos_X.value = x;
                Card_Pos_Y.value = y;
                marker = DG.marker([x, y]).addTo(map);

            })
            .on('locationerror', function (e) {
                DG.popup()
                    .setLatLng(map.getCenter())
                    .setContent('Доступ к определению местоположения отключён')
                    .openOn(map);
            });
    }
    else {
        x = Card_Pos_X.value;
        y = Card_Pos_Y.value;
        map.setView(DG.latLng(x, y), 15);
        marker = DG.marker([x, y]).addTo(map);
    }
    map.on('click', function (e) {
        marker.setLatLng([e.latlng.lat, e.latlng.lng]);
        Card_Pos_X.value = e.latlng.lat;
        Card_Pos_Y.value = e.latlng.lng;
    });
});