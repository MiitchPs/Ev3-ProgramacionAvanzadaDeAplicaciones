namespace WebApp.wwwroot.includes
{
    <header>
      <style>
        /* Carousel styling */
        #introCarousel,
        .carousel-inner,
        .carousel-item,
        .carousel-item.active {
          height: 100vh;
        }

        .carousel - item:nth - child(1) {
    background - image: url('https://mdbootstrap.com/img/Photos/Others/images/76.jpg');
    background - repeat: no - repeat;
    background - size: cover;
    background - position: center center;
}
        .carousel - item:nth - child(2) {
    background - image: url('https://mdbootstrap.com/img/Photos/Others/images/77.jpg');
    background - repeat: no - repeat;
    background - size: cover;
    background - position: center center;
}
        .carousel - item:nth - child(3) {
    background - image: url('https://mdbootstrap.com/img/Photos/Others/images/78.jpg');
    background - repeat: no - repeat;
    background - size: cover;
    background - position: center center;
}

/* Height for devices larger than 576px */
@media(min - width: 992px) {
# introCarousel {
    margin - top: -58.59px;
}
          #introCarousel,
          .carousel - inner,
          .carousel - item,
          .carousel - item.active {
height: 50vh;
}
        }

        .navbar.nav - link {
color: #fff !important;
        }
      </ style >

      < !--Navbar-- >
      < nav class= "navbar navbar-expand-lg navbar-dark d-none d-lg-block" style = "z-index: 2000;" >
        < div class= "container-fluid" >
          < !--Navbar brand-- >
          < button class= "navbar-toggler" type = "button" data - mdb - toggle = "collapse" data - mdb - target = "#navbarExample01"
            aria - controls = "navbarExample01" aria - expanded = "false" aria - label = "Toggle navigation" >
            < i class= "fas fa-bars" ></ i >
          </ button >
          < div class= "collapse navbar-collapse" id = "navbarExample01" >
            < ul class= "navbar-nav me-auto mb-2 mb-lg-0" >
                < li class= "nav-item active" >
                    < a class= "nav-link" aria - current = "page" href = "" ></ a >
              </ li >
              < li class= "nav-item active" >
                  < a class= "nav-link" aria - current = "page" href = "" ></ a >
              </ li >
            </ ul >

            < ul class= "navbar-nav d-flex flex-row" >
              < !--Icons-- >
              < li class= "nav-item me-3 me-lg-0" >
                < a class= "nav-link" href = "https://www.youtube.com/watch?v=dQw4w9WgXcQ" rel = "nofollow"
                  target = "_blank" >
                  < i class= "fab fa" ></ i >
                </ a >
              </ li >
              < li class= "nav-item me-3 me-lg-0" >
                < a class= "nav-link" href = "https://www.youtube.com/watch?v=dQw4w9WgXcQ" rel = "nofollow" target = "_blank" >
                  < i class= "fab fa" ></ i >
                </ a >
              </ li >
              < li class= "nav-item me-3 me-lg-0" >
                < a class= "nav-link" href = "https://www.youtube.com/watch?v=dQw4w9WgXcQ" rel = "nofollow" target = "_blank" >
                  < i class= "fab fa" ></ i >
                </ a >
              </ li >
              < li class= "nav-item me-3 me-lg-0" >
                < a class= "nav-link" >
                  < i class= "fab text-success" ></ i >
                </ a >
              </ li >
                 < div class= "dropdown" >
                  < a
                    class= "dropdown-toggle d-flex align-items-center hidden-arrow"
                    href = "#"
                    id = "navbarDropdownMenuAvatar"
                    role = "button"
                    data - mdb - toggle = "dropdown"
                    aria - expanded = "false"
                  >
                    < img
                        accesskey = "" src = "Icons/profile.png"
                       class= "rounded-circle"
                       height = "40"
                       alt = ""
                       loading = "lazy"
                    />
                  </ a >
                  < ul
                    class= "dropdown-menu dropdown-menu-end"
                    aria - labelledby = "navbarDropdownMenuAvatar"
                  >
                     < li >
                       < a class= "dropdown-item" href = "perfilAdministrativo.php" > Administrador </ a >
                     </ li >
                     < li >
                       < a class= "dropdown-item" href = "perfilAdministrador.php" > Administrador </ a >
                     </ li >
                     < li >
                       < a class= "dropdown-item" href = "" ></ a >
                     </ li >
                   </ ul >
                 </ div >
            </ ul >
          </ div >
        </ div >
      </ nav >
      < !--Navbar-- >

      < !--Carousel wrapper-- >
      < div id = "introCarousel" class= "carousel slide carousel-fade shadow-2-strong" data - mdb - ride = "carousel" >
        < !--Indicators-- >
        < ol class= "carousel-indicators" >
          < li data - mdb - target = "#introCarousel" data - mdb - slide - to = "0" class= "active" ></ li >
          < li data - mdb - target = "#introCarousel" data - mdb - slide - to = "1" ></ li >
          < li data - mdb - target = "#introCarousel" data - mdb - slide - to = "2" ></ li >
        </ ol >

        < !--Inner-- >
        < div class= "carousel-inner" >
          < !--Single item-- >
          < div class= "carousel-item active" >
            < div class= "mask" style = "background-color: rgba(0, 0, 0, 0.6);" >
              < div class= "d-flex justify-content-center align-items-center h-100" >
                < div class= "text-white text-center" >
                  < h1 class= "mb-3" > Proyecto Evaluacion Nº2</h1>
                  <h3 class= "mb-4" > App Registro Facturas</h3>
                  <h5 class= "mb-4" > Taller de integracion de software</h5>
                  <a
                    class= "btn btn-outline-light btn-lg m-2"
                    href = "https://www.youtube.com/watch?v=dQw4w9WgXcQ"
                    > No Pulsar </ a
                  >
                  < a
                    class= "btn btn-outline-light btn-lg m-2"
                    href = "index.php"
                    > Home </ a
                  >
                </ div >
              </ div >
            </ div >
          </ div >

          < !--Single item-- >
          < div class= "carousel-item" >
            < div class= "mask" style = "background-color: rgba(0, 0, 0, 0.3);" >
              < div class= "d-flex justify-content-center align-items-center h-100" >
                < div class= "text-white text-center" >
                  < h1 class= "mb-3" > Proyecto Evaluacion Nº2</h1>
                  <h3 class= "mb-4" > App Registro Facturas</h3>
                  <h5 class= "mb-4" > Taller de integracion de software</h5>
                </div>
              </div>
            </div>
          </div>

          <!-- Single item -->
          <div class= "carousel-item" >
            < div
              class= "mask"
              style = "
                background: linear - gradient(
                  3deg,
                  rgba(29, 236, 197, 0.7),
                  rgba(91, 14, 214, 0.7) 100 %
                );
"
>

< div class= "d-flex justify-content-center align-items-center h-100" >

  < div class= "text-white text-center" >

    < h1 class= "mb-3" > Proyecto Evaluacion Nº2</h1>
                  <h3 class= "mb-4" > App Registro Facturas</h3>
                  <h5 class= "mb-4" > Taller de integracion de software</h5>
                  <a
                    class= "btn btn-outline-light btn-lg m-3"
                    href = ""
                    > Leer mas...</ a
                  >
                </ div >
              </ div >
            </ div >
          </ div >
        </ div >
        < !--Inner-- >

        < !--Controls-- >
        < a class= "carousel-control-prev" href = "#introCarousel" role = "button" data - mdb - slide = "prev" >
          < span class= "carousel-control-prev-icon" aria - hidden = "true" ></ span >
          < span class= "sr-only" > Anterior </ span >
        </ a >
        < a class= "carousel-control-next" href = "#introCarousel" role = "button" data - mdb - slide = "next" >
          < span class= "carousel-control-next-icon" aria - hidden = "true" ></ span >
          < span class= "sr-only" > Siguiente </ span >
        </ a >
      </ div >
      < !--Carousel wrapper-- >
    </ header >
    < !--Footer-- >
    < footer class= "bg-light text-lg-start" >
      < div class= "py-4 text-center" >

      </ div >
    </ footer >
}
