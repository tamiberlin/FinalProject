export default function Home() {
    return (
        <>
            <h1>
                home page
            </h1>

            <div className="card-group" style={{ justifyContent: "space-around" }}>


                <a href="./flights">
                    <div class="card" style={{ width: "22rem" }}>
                        <div class="card-body">
                            <center>
                                <h5 class="link-success link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover">flights</h5></center>
                        </div>
                    </div>
                </a>
                <a href="./attractions">
                    <div class="card" style={{ width: "22rem" }}>
                        <div class="card-body">
                            <center>
                                <h5 class="link-success link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover">attractions</h5></center>
                        </div>
                    </div>
                </a>
                <a href="./housing">
                    <div class="card" style={{ width: "22rem" }}>
                        <div class="card-body">
                            <center>
                                <h5 class="link-success link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover">housing</h5></center>
                        </div>
                    </div>
                </a>
                <a href="./orgenizedTours">
                    <div class="card" style={{ width: "22rem" }}>
                        <div class="card-body">
                            <center>
                                <h5 class="link-success link-offset-2 link-underline-opacity-25 link-underline-opacity-100-hover">orgenized tours</h5></center>
                        </div>
                    </div>
                </a>
            </div >

        </>
    )
}