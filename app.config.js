import { defineConfig } from "@solidjs/start/config";
import devtools from "solid-devtools/vite";

export default defineConfig({
    // Change to project name as required
    appRoot: "./Partas.Solid.Start.Template",
    routeDir: "./routes",
    // Recommended to use .fs.jsx extension so that fable clean will not
    // wipe out solid-start files
    extensions: [ 'js', 'jsx' , 'ts', 'tsx', 'fs.jsx' ],
    // Vite config
    vite: {
        plugins:[
            devtools({
                autoname: true
            })
        ],
        server: {
            watch: {
                ignore: [
                    "**/*.md",
                    "**/*.fs",
                    "**/*.fsx"
                ]
            }
        }
    },
    // Vinxi/Nitro/SolidStart
    server: {
        // preset: "vercel"
    }
});
